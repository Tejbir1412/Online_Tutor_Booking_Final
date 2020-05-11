1. Open the Solution in Visual Studio
2. Build the project 
3. Navigate to tools ans select Nuget Package manager -> Package Manager Console (PMC)
4. On the console execute the following command
 Update-Database -Context Online_Tutor_Booking_IdentityContext


5. On the console execute the following command

 Update-Database -Context Online_Tutor_Booking_DataContext



6. After migration is successful Run the project 

7 if you login as admin  from the following credentials will be able to see the Students,  
Tutors  and Bookings Links. Admin can add and update Tutors 

User : admin@gmail.com
Password: Passwd@1234

8. Also you can login with the following credentials to visit the site as a Student or sign up as a student 
Can add booking requests for Tutors

 User : pamela@gmail.com
Password: Passwd@1234



9 if you need to create another  admin login with the admin credentials on step 7 above and
Click in "Register tutor admin" register a new admin 





The identity  authentication code used in the project were obtained by following URLS

Introduction to Identity on ASP.NET Core
https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-3.0&tabs=visual-studio
