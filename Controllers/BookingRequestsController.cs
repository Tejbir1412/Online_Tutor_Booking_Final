using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Online_Tutor_Booking_Final.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Online_Tutor_Booking_Final.Controllers
{
    
    public class BookingRequestsController : Controller
    {
        private readonly Online_Tutor_Booking_DataContext _context;

        public BookingRequestsController(Online_Tutor_Booking_DataContext context)
        {
            _context = context;
        }

        // GET: BookingRequests
        [Authorize(Roles="tutor_admin, student")]
        public async Task<IActionResult> Index()
        {
            var online_Tutor_Booking_DataContext = _context.BookingRequest.Include(b => b.Student).Include(b => b.Tutor);

            if (User.IsInRole("student")) {


                var online_Tutor_Booking_DataContextStudent = _context.BookingRequest.
                    Include(b => b.Student).
                    Include(b => b.Tutor).
                    Where (b =>b.Student.Email.Equals(User.Identity.Name));

                return View(await online_Tutor_Booking_DataContextStudent.ToListAsync());
            }


            return View(await online_Tutor_Booking_DataContext.ToListAsync());
        }

        // GET: BookingRequests/Details/5
        [Authorize(Roles = "tutor_admin, student")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingRequest = await _context.BookingRequest
                .Include(b => b.Student)
                .Include(b => b.Tutor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookingRequest == null)
            {
                return NotFound();
            }

            return View(bookingRequest);
        }

        // GET: BookingRequests/Create
        [Authorize(Roles = "student")]
        public IActionResult Create()
        {
          
            ViewData["TutorId"] = new SelectList(_context.Set<Tutor>(), "Id", "Name");
            return View();
        }

        // POST: BookingRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize(Roles = "student")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TutorId,BookingDate")] BookingRequest bookingRequest)
        {

            var student = (from stu in _context.Student
                           where stu.Email.Equals(User.Identity.Name)
                           select stu).FirstOrDefault();
            if (ModelState.IsValid)
            {
                bookingRequest.StudentId = student.Id;
                _context.Add(bookingRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           
            ViewData["TutorId"] = new SelectList(_context.Set<Tutor>(), "Id", "Name", bookingRequest.TutorId);
            return View(bookingRequest);
        }

        // GET: BookingRequests/Edit/5
        [Authorize(Roles = "tutor_admin, student")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingRequest = await _context.BookingRequest.FindAsync(id);
            if (bookingRequest == null)
            {
                return NotFound();
            }
         
            ViewData["TutorId"] = new SelectList(_context.Set<Tutor>(), "Id", "Name", bookingRequest.TutorId);
            return View(bookingRequest);
        }

        // POST: BookingRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize(Roles = "tutor_admin, student")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StudentId,TutorId,BookingDate")] BookingRequest bookingRequest)
        {
            if (id != bookingRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookingRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingRequestExists(bookingRequest.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
           
            ViewData["TutorId"] = new SelectList(_context.Set<Tutor>(), "Id", "Name", bookingRequest.TutorId);
            return View(bookingRequest);
        }

        // GET: BookingRequests/Delete/5
        [Authorize(Roles = "tutor_admin, student")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingRequest = await _context.BookingRequest
                .Include(b => b.Student)
                .Include(b => b.Tutor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookingRequest == null)
            {
                return NotFound();
            }

            return View(bookingRequest);
        }

        // POST: BookingRequests/Delete/5
        [Authorize(Roles = "tutor_admin, student")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookingRequest = await _context.BookingRequest.FindAsync(id);
            _context.BookingRequest.Remove(bookingRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingRequestExists(int id)
        {
            return _context.BookingRequest.Any(e => e.Id == id);
        }
    }
}
