using CareerHub__The_Job_Board.DAO;
using CareerHub__The_Job_Board.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
namespace CareerHub__The_Job_Board.main
{
    internal class main
    {
        static SqlConnection conn;
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE JOB BOARD");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("SELECT FROM BELOW:");
                Console.WriteLine("JOBS");
                Console.WriteLine("----");
                Console.WriteLine("1.Add the JobListing");
       
                Console.WriteLine("COMPANIES");
                Console.WriteLine("---------");
                Console.WriteLine("2.Add new Company");
                Console.WriteLine("3.List all the Companies");
                Console.WriteLine("APPLICANTS");
                Console.WriteLine("----------");
                Console.WriteLine("4.Add new Applicant");
                Console.WriteLine("5.List all the Applicants");
                Console.WriteLine("JOB APPLICATIONS");
                Console.WriteLine("----------------");
                Console.WriteLine("6.Add new JobApplication");
                Console.WriteLine("7.List all the Applications");
                Console.WriteLine("8.EXIT.");
                Console.WriteLine();
                Console.Write("ENTER YOUR CHOICE: ");
                int x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        try
                        {
                            IDatabaseManager databaseManager = new DatabaseManager();
                            Console.WriteLine("ENTER THE JOB DETAILS:");
                            JobListing job = new JobListing();
                            job.JobID = Convert.ToInt32(Console.ReadLine());
                            job.CompanyID = Convert.ToInt32(Console.ReadLine());
                            job.JobTitle = Console.ReadLine();
                            job.JobDescription = Console.ReadLine();
                            job.JobLocation = Console.ReadLine();
                            job.Salary = Convert.ToDecimal(Console.ReadLine());
                            job.JobType = Console.ReadLine();
                            job.PostedDate = Convert.ToDateTime(Console.ReadLine());
                            //Console.WriteLine( databaseManager.InsertJobListing(JobListing job);
                            databaseManager.InsertJobListing(job);
                            Console.WriteLine($"{job.JobID} \n {job.CompanyID}\n {job.JobTitle} \n {job.JobDescription}\n {job.JobLocation} \n {job.Salary}\n {job.JobType} \n {job.PostedDate}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        continue;
                    
                    case 2:
                        try
                        {
                            IDatabaseManager databaseManager = new DatabaseManager();
                            Console.WriteLine("ENTER THE COMPANY DETAILS:");
                            Company company = new Company();
                            company.CompanyID = Convert.ToInt32(Console.ReadLine());
                            company.CompanyName = Console.ReadLine();
                            company.Location = Console.ReadLine();
                            //Console.WriteLine( databaseManager.InsertCompany(Company company);
                            databaseManager.InsertCompany(company);
                            Console.WriteLine($"{company.CompanyID} \n {company.CompanyName}\n {company.Location}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        continue;
                    case 3:
                        try
                        {
                            IDatabaseManager databaseManager = new DatabaseManager();
                            List<Company> com = databaseManager.GetCompanies();
                            foreach (Company c in com)
                            {
                                Console.WriteLine($"{c.CompanyID}\t {c.CompanyName}\t {c.Location}");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        continue;
                    case 4:
                        try
                        {
                            IDatabaseManager databaseManager = new DatabaseManager();
                            Console.WriteLine("ENTER THE APPLICANTS DETAILS:");
                            Applicant applicant = new Applicant();
                            applicant.ApplicantID = Convert.ToInt32(Console.ReadLine());
                            applicant.FirstName = Console.ReadLine();
                            applicant.LastName = Console.ReadLine();
                            applicant.Email = Console.ReadLine();
                            applicant.Phone = Console.ReadLine();
                            applicant.Resume = Console.ReadLine();
                            //Console.WriteLine( databaseManager.InsertApplicant(applicant);
                            databaseManager.InsertApplicant(applicant);
                            Console.WriteLine($"{applicant.ApplicantID} \n {applicant.FirstName} \n {applicant.LastName} \n {applicant.Email} \n {applicant.Phone} \n {applicant.Resume}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        continue;
                    case 5:
                        try
                        {
                            IDatabaseManager databaseManager = new DatabaseManager();
                            List<Applicant> jobapp = databaseManager.GetApplicants();
                            foreach (Applicant ja in jobapp)
                            {
                                Console.WriteLine($"{ja.ApplicantID}\t {ja.FirstName}\t {ja.LastName}\t {ja.Email}\t {ja.Phone}\t {ja.Resume}");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        continue;
                    case 6:
                        try
                        {
                            IDatabaseManager databaseManager = new DatabaseManager();
                            Console.WriteLine("ENTER THE APPLICATION DETAILS:");
                            JobApplication application = new JobApplication();
                            application.ApplicationID = Convert.ToInt32(Console.ReadLine());
                            application.JobID = Convert.ToInt32(Console.ReadLine());
                            application.ApplicantID = Convert.ToInt32(Console.ReadLine());
                            application.ApplicationDate = Convert.ToDateTime(Console.ReadLine());
                            application.CoverLetter = Console.ReadLine();
                            //Console.WriteLine(  databaseManager.InsertJobApplication(application);
                            databaseManager.InsertJobApplication(application);
                            Console.WriteLine($"{application.ApplicationID} \n {application.JobID} \n {application.ApplicationID} \n {application.ApplicationDate} \n {application.CoverLetter}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        continue;
                    case 7:
                        try
                        {
                            IDatabaseManager databaseManager = new DatabaseManager();
                            List<JobApplication> jobapplic = databaseManager.GetApplicationsForJob();
                            foreach (JobApplication jap in jobapplic)
                            {
                                Console.WriteLine($"{jap.ApplicationID}\t {jap.JobID}\t {jap.ApplicantID}\t {jap.ApplicationDate}\t {jap.CoverLetter}\t");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        continue;
                    case 8:
                        Console.WriteLine("Exiting program.");
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        continue;
                }
            }
        }
    }
}
    
