using HandsOnEFCoreFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HandsOnEFCoreFirst
{
    class ProjectRepository
    {
        public static void AddProjects(Project project)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                    db.Project.Add(project);
                    db.SaveChanges();
            }
   
        }
        
        public static void GetProjects()
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                List<Project> list = db.Project.ToList();
                foreach (var item in list)
                {
                    Console.WriteLine("{0} {1} {2} ", item.ProjectId, item.ProjectName, item.TeamSize);
                }
            }
         
        }
        static void Main(string[] args)
        {
            Project p1 = new Project()
            {
                ProjectId = "P002",
                ProjectName="SanjeevaniApp",
                TeamSize=4
        
            };
            //AddProjects(p1);
            GetProjects();

        }
    }
}
