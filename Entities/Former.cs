using App.WinForm.Attributes;
using App.WinForm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DisplayEntity(Localizable = true, DisplayMember = "Name")]
    [Menu]
    public class Former:BaseEntity
    {
        [DisplayProperty(Titre = "Cne")]
        [EntryForm(Ordre = 1, WidthControl = 300)]
        [Filter]
        [DataGrid(WidthColonne = 100)]
        public string Cne { get; set; }

        [DisplayProperty(Titre = "Name")]
        [EntryForm(Ordre = 1, WidthControl = 300)]
        [Filter]
        [DataGrid(WidthColonne = 100)]
        public string Name { get; set; }

        [DisplayProperty(Titre = "Module")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        [EntryForm(Ordre = 4, WidthControl = 300)]
        [DataGrid]
        [Filter]
        public List<Module> ListeModules { get; set; }
    }
}
