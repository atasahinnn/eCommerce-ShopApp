using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopApp.Business.Abstract;
using ShopApp.Entity;
using ShopApp.WEBUI.Identity;
using ShopApp.WEBUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBUI.Controllers
{
    // atasahin => admin
    // ROL NULL OLURSA ULAŞAMAZ.
    // [AllowAnonymous] LOGIN OLMAYAN GÖREBİLİR. ACC CONT. ALTINDA VAR.


    [Authorize(Roles = "admin")]
    public class AdminController:Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;

        public AdminController(IProductService productService, ICategoryService categoryService, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _productService = productService;
            _categoryService = categoryService;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }

        public IActionResult RoleCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(model.Name));
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> RoleEdit(string id)    
        {
            var role = await _roleManager.FindByIdAsync(id);

            var members = new List<User>();
            var nonMembers = new List<User>();

            foreach (var user in _userManager.Users.ToList())
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    members.Add(user);
                }
                else
                {
                    nonMembers.Add(user);
                }
            }
            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }

                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }
            }

            return Redirect("/admin/role/" + model.RoleId);
        }

        public async Task <IActionResult> ProductList()
        {
            var products = await _productService.GetAll();
            return View(new ProductListViewModel()
            {
                Products = products
            });
        }

        public async Task <IActionResult> CategoryList()
        {
            var categories = await _categoryService.GetAll();
            return View(new CategoryListViewModel()
            {
                Categories =  categories
            });
        }

        [HttpGet]
        public IActionResult CategoryCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryCreate(Category model)
        {

            var entity = new Category()
            {
                Name = model.Name,
                Url = model.Url,
            };

            _categoryService.Create(entity);

            var message = new AlertMessage()
            {
                Message = $"{entity.Name} İsimli Kategori Eklendi.",
                AlertType = "success"
            };

            TempData["message"] = JsonConvert.SerializeObject(message);

            return RedirectToAction("CategoryList");          
        }

        [HttpGet]
        public IActionResult CategoryEdit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var entity = _categoryService.GetByIdWithProducts((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new CategoryModel()
            {
                CategoryId = entity.CategoryId,
                Url = entity.Url,
                Name = entity.Name, 
                Products = entity.ProductCategories.Select(p=> p.Product).ToList()

            };
            return View(model);
        }

        [HttpPost]
        public async Task <IActionResult> CategoryEdit(CategoryModel model)
        {
            if (ModelState.IsValid)
            {

                var entity = await _categoryService.GetByID(model.CategoryId);
                if (entity == null)
                {
                    return NotFound();
                }

                entity.CategoryId = model.CategoryId;
                entity.Name = model.Name;
                entity.Url = model.Url;


                _categoryService.Update(entity);

                var message = new AlertMessage()
                {
                    Message = $"{entity.Name} İsimli Kategori Güncellendi.",
                    AlertType = "warning"
                };

                TempData["message"] = JsonConvert.SerializeObject(message);

                return RedirectToAction("CategoryList");
            }
            return View(model);
        }

        public async Task <IActionResult> DeleteCategory (int categoryId)
        {
            var entity = await _categoryService.GetByID(categoryId);

            if (entity != null)
            {
                _categoryService.Delete(entity);
            }

            var message = new AlertMessage()
            {
                Message = $"{entity.Name} İsimli Kategori Silindi.",
                AlertType = "danger"
            };

            TempData["message"] = JsonConvert.SerializeObject(message);

            return RedirectToAction("CategoryList");
        }

        [HttpGet]
        public IActionResult ProductCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProductCreate(Product model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Product()
                {
                    Name = model.Name,
                    Url = model.Url,
                    Price = model.Price,
                    ImageUrl = model.ImageUrl,
                    Description = model.Description,
                };

                _productService.Create(entity);

                var message = new AlertMessage()
                {
                    Message = $"{entity.Name} İsimli Ürün Eklendi.",
                    AlertType = "success"
                };

                TempData["message"] = JsonConvert.SerializeObject(message);
                return RedirectToAction("ProductList");
            }

            return View(model);
            
        }

        [HttpGet]
        public async Task <IActionResult> ProductEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _productService.GetByIdWithCategories((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new ProductModel()
            {
                Url = entity.Url,
                ProductId = entity.ProductId,
                Name = entity.Name,
                Description = entity.Description,
                ImageUrl = entity.ImageUrl,
                Price = entity.Price,
                SelectedCategories = entity.ProductCategories.Select(i => i.Category).ToList()
                               
            };

            ViewBag.Categories = await _categoryService.GetAll();

            return View(model);
        }

        [HttpPost]
        public async Task <IActionResult> ProductEdit(ProductModel model, int[] categoryIds, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var entity = await _productService.GetByID(model.ProductId);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.Name = model.Name;
                entity.Price = model.Price;
                entity.Url = model.Url;
                entity.Description = model.Description;

                if (file != null) // IMAGE UPLOAD
                {
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    entity.ImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", randomName);

                    using(var stream = new FileStream(path,FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }

                _productService.Update(entity, categoryIds);

                var message = new AlertMessage()
                {
                    Message = $"{entity.Name} İsimli Ürün Güncellendi.",
                    AlertType = "warning"
                };

                TempData["message"] = JsonConvert.SerializeObject(message);

                return RedirectToAction("ProductList");
            }
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }

        public async Task <IActionResult> DeleteProduct(int productId)
        {
            var entity  = await _productService.GetByID(productId);

            if (entity != null)
            {
                _productService.Delete(entity);
            }

            var message = new AlertMessage()
            {
                Message = $"{entity.Name} İsimli Ürün Silindi.",
                AlertType = "danger"
            };

            TempData["message"] = JsonConvert.SerializeObject(message);

            return RedirectToAction("ProductList");
        }
        [HttpPost]
        public IActionResult DeleteFromCategory(int productId, int categoryId)
        {
            _categoryService.DeleteFromCategory(productId, categoryId);
            return Redirect("/admin/categories/" + categoryId);
        }

        public IActionResult UserList()
        {
            return View(_userManager.Users);
        }
        [HttpGet]
        public async Task <IActionResult> UserEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                var selectedRoles = await _userManager.GetRolesAsync(user);
                var roles = _roleManager.Roles.Select(i => i.Name);
                ViewBag.Roles = roles;
                return View(new UserDetailsModel()
                {
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    SelectedRoles = selectedRoles
                });
            }
            return Redirect("~/admin/user/list");
        }
        [HttpPost]
        public async Task<IActionResult> UserEdit(UserDetailsModel model, string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.EmailConfirmed = model.EmailConfirmed;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        selectedRoles = selectedRoles ?? new string[] { };

                        await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles).ToArray<string>());
                        await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles).ToArray<string>());

                        return RedirectToAction("UserList", "Admin");
;                    }
                }
                return RedirectToAction("UserList", "Admin");
            }
            return View(model);
        }
    }
}
