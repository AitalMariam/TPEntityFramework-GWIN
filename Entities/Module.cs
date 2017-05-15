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
    public class Module:BaseEntity
    {
        [DisplayProperty(Titre = "Description")]
        [EntryForm(Ordre = 2, WidthControl = 300)]
        [Filter]
        public string Description { get; set; }

        [DisplayProperty(Titre = "Name")]
        [EntryForm(Ordre = 1, WidthControl = 300)]
        [Filter]
        public string Name { get; set; }


        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        [Filter]
        public List<Former> ListeFormers { get; set; }
    }
}
