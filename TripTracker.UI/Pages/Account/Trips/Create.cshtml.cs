﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TripTracker.UI.Data;
using tripTracker.BackService.Models;

namespace TripTracker.UI.Pages.Account.Trips
{
    public class CreateModel : PageModel
    {
        private readonly TripTracker.UI.Data.ApplicationDbContext _context;

        public CreateModel(TripTracker.UI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Trip Trip { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Trip.Add(Trip);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}