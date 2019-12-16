using Microsoft.AspNetCore.Mvc;

namespace mvcapp.Controllers
{
    public class AccountController : Controller
    {
        public string Login(){
            return "Lütfen Kullanıcı Bilgilerizi Giriniz";
        }
    }
}