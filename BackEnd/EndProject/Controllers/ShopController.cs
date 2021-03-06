﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
using EndProject.ViewModels;
using EndProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EndProject.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _db;
        public ShopController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int? page,string productCategory)
        {
            if (productCategory!=null)
            {
                ViewBag.PageShop = page;
                ViewBag.PageCountShop = Math.Ceiling((decimal)_db.Products.Where(p=>p.ProductCategory.Name== productCategory).Count() / 6);
                if (page == null)
                {
                    ProductVM productVM = new ProductVM()
                    {
                        Products = _db.Products.Where(p=>p.ProductCategory.Name.ToLower().Trim()== productCategory.ToLower().Trim()).Include(p => p.ProductImages).Take(6).ToList(),
                        ProductCategories = _db.ProductCategories.ToList()
                    };
                    return View(productVM);
                }
                else
                {
                    ProductVM productVM = new ProductVM()
                    {
                        Products = _db.Products.Include(p => p.ProductImages).Skip((int)(page - 1) * 6).Take(6).ToList(),
                        ProductCategories = _db.ProductCategories.ToList()
                    };
                    return View(productVM);
                }
            }
            else
            {

                ViewBag.PageShop = page;
                ViewBag.PageCountShop = Math.Ceiling((decimal)_db.Products.Count() / 6);
                if (page == null)
                {
                    ProductVM productVM = new ProductVM()
                    {
                        Products = _db.Products.Include(p => p.ProductImages).Take(6).ToList(),
                        ProductCategories = _db.ProductCategories.ToList()
                    };
                    return View(productVM);
                }
                else
                {
                    ProductVM productVM = new ProductVM()
                    {
                        Products = _db.Products.Include(p => p.ProductImages).Skip((int)(page - 1) * 6).Take(6).ToList(),
                        ProductCategories = _db.ProductCategories.ToList()
                    };
                    return View(productVM);
                }
            }

        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Product product = _db.Products.Find(id);
            if (product == null) return NotFound();
            ProductVM productVM = new ProductVM()
            {
                Productt = _db.Products.Find(id),
                ProductCategories = _db.ProductCategories.ToList(),
                ProductImages = _db.ProductImages.Where(p => p.ProductId == product.Id).ToList(),
                Products = _db.Products.Include(p => p.ProductImages).Where(p => p.ProductCategoryId == product.ProductCategoryId).ToList()
            };

            return View(productVM);
        }
        public IActionResult AddToCart(int? id, string actionName, string queryString)
        {

            if (id == null) return NotFound();
            Product product = _db.Products.Include(P => P.ProductImages).FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            string existCookie = Request.Cookies["cart"];
            List<ProducttVM> products;
            if (existCookie == null)
            {
                products = new List<ProducttVM>();
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<ProducttVM>>(existCookie);
            }
            ProducttVM existPro = products.FirstOrDefault(p => p.Id == id);
            if (existPro == null)
            {
                List<ProductImage> productImages = new List<ProductImage>();
                ProductImage productImage = _db.ProductImages.Include(p => p.Product).FirstOrDefault(p => p.IsMain == true && p.ProductId == id);
                productImages.Add(productImage);
                ProducttVM newProduct = new ProducttVM
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Count = 1,
                    Image = productImage.Image
                };
                products.Add(newProduct);
            }
            else
            {
                existPro.Count += 1;
            }
            string cart = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("cart", cart, new Microsoft.AspNetCore.Http.CookieOptions { MaxAge = TimeSpan.FromDays(15) });
            
            if (actionName.ToLower().Contains("detail"))
            {
                return Redirect("/Shop/Detail/" + id);
            }
            else
            {
                return Redirect("/Shop" + queryString);
            }
           
        }
        public IActionResult Buy()
        {
           
            if (Request.Cookies["cart"] != null)
            {
                string b = Request.Cookies["cart"];
                SaleVM saleVM = new SaleVM()
                {
                    ProductVM = JsonConvert.DeserializeObject<List<ProducttVM>>(b)
                };
               
                return View(saleVM);
            }
            return View();
            
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buy(SaleVM salee)
        {
            decimal total = 0;
            string cart = Request.Cookies["cart"];
            List<ProducttVM> products = JsonConvert.DeserializeObject<List<ProducttVM>>(cart);

            Sale sale = new Sale()
            {
                PhoneNumber = salee.PhoneNumber,
                FullName = salee.FullName,
                Date = DateTime.Now
            };

            List<SaleProduct> saleProduct = new List<SaleProduct>();
            foreach (ProducttVM product in products)
            {
                total += product.Price * product.Count;
                saleProduct.Add(new SaleProduct
                {
                    Count = product.Count,
                    Price = product.Price,
                    SaleId = sale.Id,
                    ProductId = product.Id
                });

            }
            sale.Total = total;
            sale.SaleProducts = saleProduct;
            _db.Sales.Add(sale);
            await _db.SaveChangesAsync();
            if (Request.Cookies["cart"] != null)
            {
                Response.Cookies.Delete("cart");
            }
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int? id)
        {
            if (id == null) return NotFound();
             
            if (Request.Cookies["cart"] == null) return NotFound();
            string bas = Request.Cookies["cart"];
            List<ProducttVM> products =JsonConvert.DeserializeObject<List<ProducttVM>>(bas);
            foreach (ProducttVM product in products.ToList())
            {

                if (product.Id == id)
                {
                    products.Remove(product);
                }
            }
            string cart = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("cart", cart, new  Microsoft.AspNetCore.Http.CookieOptions { MaxAge = TimeSpan.FromDays(15) });
            return RedirectToAction("Buy");

            

        }
    }
}