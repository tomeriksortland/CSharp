using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Oblig1__familietre
{
    public class FamilyApp
    {
        public List<Person> _people;
        public string WelcomeMessage { get; set; }
        public string CommandPrompt { get; set; }

        public FamilyApp(params Person[] people)
        {
            WelcomeMessage = "Velkommen til Familietre.";
            _people = new List<Person>(people);
        }

        public string HandleCommand(string command)
        {
            var dosCommands = "Dette er kommandoene du kan utføre: liste og vis (ID)";

            if (command == "help") return dosCommands;

            if (command == "liste")
            {
                string infoFromAllPersons = null;
                foreach (var Person in _people)
                {
                    infoFromAllPersons += Person.GetDescription();
                }
                return infoFromAllPersons;
            }
            foreach (var Person in _people)
            {
                if (command == $"vis {Person.Id}")
                {
                    var children = FindChildren(Person);
                    var description = Person.GetDescription();
                    description = AddChildrenInfo(children, description);
                    return description;
                }
                

            }
            return "Bruk kommandoene: liste eller vis (ID), eller prøv en annen ID.";
        }

        private string AddChildrenInfo(List<Person> children, string infoFromAllPersons)
        {
            if (children.Count <= 0) return infoFromAllPersons;
            infoFromAllPersons += " Barn:\n ";
            foreach (var child in children)
            {
                infoFromAllPersons += $" {child.FirstName} (ID={child.Id}) Født: {child.BirthYear} \n";
            }

            return infoFromAllPersons;
        }

        private List<Person> FindChildren(Person person)
        {
            var children = new List<Person>();
            foreach (var child in _people)
            {
                if(child.Father == person || child.Mother == person) children.Add(child);
            }

            return children;
        } 
    }
}
