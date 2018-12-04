using PortfolioRebuild.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioRebuild.DAL
{
    public class ProjectInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {
            var projects = new List<Project>
            {
                new Project
                {
                    Name = "Whiteboard Chronicle",
                    Timeline = "November 2018",
                    Summary = "Save your whiteboards by uploading photos of them into a searchable database. Saved whiteboards can be searched by tag or sorted by date and project team.",
                    Languages = "C#, MVC, Javascript",
                    Screenshot = "assets\\whiteboard.jpg",
                    GitHub = "https://github.com/lucasdtownsend/WhiteboardChronicle"
                },
                new Project
                {
                    Name = "Lucas Makes Lists",
                    Timeline = "",
                    Summary = "Designed for Windows tablets, Lucas Makes Lists allows users to easily create lists and rank them with a simple, satisfying drag-and-drop interface.",
                    Languages = "C# for Windows tablets",
                    Screenshot = "assets\\lml.jpg",
                    GitHub = "https://github.com/lucasdtownsend/LucasMakesLists"
                },
                new Project
                {
                    Name = "Fighting Game Sensei",
                    Timeline = "",
                    Summary = "Practice moves from fighting games like Street Fighter with fully animated characters and interactive guides. Compatible with keyboard and USB controllers.",
                    Languages = "C#, WPF",
                    Screenshot = "assets//fgt.png",
                    GitHub = "https://github.com/lucasdtownsend/streetfight"
                },
                new Project
                {
                    Name = "Disco Tetris",
                    Timeline = "",
                    Summary = "Standard Tetris with color-changing blocks and a funkadelic soundtrack.",
                    Languages = "Python",
                    Screenshot = "assets//tetris.png",
                    GitHub = "https://github.com/lucasdtownsend/discotetris"
                }
            };
            context.Projects.AddRange(projects);

            base.Seed(context);
        }
    }
}