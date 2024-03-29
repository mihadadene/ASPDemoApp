﻿using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            PersonModel p = new PersonModel();
            //int i = 5 /p.Age;
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Tim", LastName = "Corey", Age = 38 });
            people.Add(new PersonModel { FirstName = "Joe", LastName = "Smith", Age = 56 });
            people.Add(new PersonModel { FirstName = "Sarah", LastName = "Connor", Age = 25 });
            people.Add(new PersonModel { FirstName = "Med", LastName = "Ihadadene", Age = 42 });

            return View(people);
        }
    }
}