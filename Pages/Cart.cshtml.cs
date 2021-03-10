using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assign5.Infastructure;
using Assign5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assign5.Pages
{
    public class CartModel : PageModel
    {
        private Models.IProjectRepository repository;
        //Constructor
        public CartModel(IProjectRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }
        //properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        
        //methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }
        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Project project = repository.Projects.FirstOrDefault(p => p.BookId == bookId);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(project, 1);
            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Project.BookId == bookId).Project);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
