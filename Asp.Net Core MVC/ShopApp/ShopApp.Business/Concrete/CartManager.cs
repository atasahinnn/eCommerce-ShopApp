using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Concrete
{
    public class CartManager : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CartManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddToCart(string userId, int productId, int quantity)
        {
            var cart = GetCartByUserID(userId);
            if (cart != null)
            {
                // EKLENMEK İSTENEN ÜRÜN SEPETTE VARSA ADET ARTTIRMA (GÜNCELLEME)
                var index = cart.CartItem.FindIndex(i => i.ProductId == productId);

                if (index < 0)
                {
                    cart.CartItem.Add(new CartItem()
                    {
                        ProductId = productId,
                        Quantity = quantity,
                        CartId = cart.Id
                    });
                }
                else
                {
                    cart.CartItem[index].Quantity += quantity;
                }

                _unitOfWork.Carts.Update(cart);
                _unitOfWork.Save();
            }

            // EKLENMEK İSTENEN ÜRÜN SEPETTE VAR FAKAT YENİ KAYIT OLUŞTURMAK İSTENİRSE
        }

        public void ClearCart(int cartId)
        {
            _unitOfWork.Carts.ClearCart(cartId);
        }

        public void DeleteFromCart(string userId, int productId)
        {
            var cart = GetCartByUserID(userId);
            if (cart != null)
            {
                _unitOfWork.Carts.DeleteFromCart(cart.Id, productId);
            }
        }

        public Cart GetCartByUserID(string id)
        {
            return _unitOfWork.Carts.GetByUserID(id);
        }

        public void InitializeCart(string userId)
        {
            _unitOfWork.Carts.Create(new Cart()
            {
                UserId = userId
            });

            _unitOfWork.Save();
        }
    }
}
