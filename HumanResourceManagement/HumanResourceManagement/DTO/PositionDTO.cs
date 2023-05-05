using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.DTO
{
    public class PositionDTO
    {
        private string idPosition;
        private string namePosition;
        private string descriptionPosition;

        public string IdPosition { get => idPosition; set => idPosition = value; }
        public string NamePosition { get => namePosition; set => namePosition = value; }
        public string DescriptionPosition { get => descriptionPosition; set => descriptionPosition = value; }

        public PositionDTO(string idPosition, string namePosition, string descriptionPosition)
        {
            this.IdPosition = idPosition;
            this.NamePosition = namePosition;
            this.descriptionPosition = descriptionPosition;
        }

        public PositionDTO(DataRow row)
        {
            this.idPosition = row["idPosition"].ToString();
            this.namePosition = row["namePosition"].ToString();
            this.descriptionPosition = row["descriptionPosition"].ToString();
        }
    }
}
