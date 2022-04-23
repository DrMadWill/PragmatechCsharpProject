using ApiProject.Models;
using CallWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CallWebApi.Controllers
{
    public class StudentController : Controller
    {
        private readonly string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJ3aWxsQGdhbWlsLmNvbSIsIklkIjoiMSIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IlVzZXIiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiV2lsbCIsImV4cCI6MTY1MDc0NzkyMCwiaXNzIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NDQzMjcvIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NDQzMjcvIn0.WF9wJzq_wjDmM-vvy8htjTUkJjt_dT6i8W4ci9PavqI";
        public async Task<IActionResult> Index()
        {
            List<Student> reservationList = new List<Student>();
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                using var response = await httpClient.GetAsync("https://localhost:44327/api/Student");
                string apiResponse = await response.Content.ReadAsStringAsync();
                reservationList = JsonConvert.DeserializeObject<List<Student>>(apiResponse);
            }
            return View(reservationList);
        }

        [HttpGet]
        public async Task<IActionResult> Create() 
        {
            List<Group> groups = new List<Group>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44327/api/Group"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        groups = JsonConvert.DeserializeObject<List<Group>>(apiResponse);
                    }
                }
            }

            ViewBag.Groups = groups;

            return View(new Student());
                
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new(JsonConvert.SerializeObject(student), Encoding.UTF8, "application/json");

                using var response = await httpClient.PostAsync("https://localhost:44327/api/student", content);
                string apiResponse = await response.Content.ReadAsStringAsync();
                student = JsonConvert.DeserializeObject<Student>(apiResponse);
            }
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Student student = new();
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync("https://localhost:44327/api/Student/"+id);
                string apiResponse = await response.Content.ReadAsStringAsync();
                student = JsonConvert.DeserializeObject<Student>(apiResponse);
            }

            List<Group> groups = new List<Group>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44327/api/Group"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        groups = JsonConvert.DeserializeObject<List<Group>>(apiResponse);
                    }
                }
            }

            ViewBag.Groups = groups;

            return View("Create", student);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Student student)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new(JsonConvert.SerializeObject(student), Encoding.UTF8, "application/json");

                using var response = await httpClient.PutAsync("https://localhost:44327/api/Student", content);
            }
            return Redirect("/Student/Index");
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            using (var httpClient = new HttpClient())
            {
                using var resopnse = await httpClient.DeleteAsync("https://localhost:44327/api/Student/" + id);
            }
            return Redirect("/Student/Index");
        }

    }
}
