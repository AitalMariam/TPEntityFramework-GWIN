using App.WinForm.Attributes;
using App.WinForm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DisplayEntity(Localizable = true, DisplayMember = "FirstName")]
    [Menu]
    public class Trainee:BaseEntity
    {
        [DisplayProperty(Titre = "FirstName")]
        [EntryForm(Ordre = 1, WidthControl = 300)]
        [Filter]
        [DataGrid(WidthColonne = 100)]
        public string FirstName { get; set; }

        [DisplayProperty(Titre = "LastName")]
        [EntryForm(Ordre = 2, WidthControl = 300)]
        [Filter]
        [DataGrid(WidthColonne = 100)]
        public string LastName { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(Ordre = 3)]
        [Filter]
        [DataGrid(WidthColonne = 100)]
        public Group Group { get; set; }
    }
}
