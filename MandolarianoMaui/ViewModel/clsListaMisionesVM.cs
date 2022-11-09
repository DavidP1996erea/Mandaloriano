using BL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandolarianoMaui.ViewModel
{
    public class clsListaMisionesVM
    {

        public List <clsMisiones> listaMisionesCompleta { get; set; }

        
        public clsListaMisionesVM()
        {

            listaMisionesCompleta = clsListaMisionesBL.listaMisionesCompletaBL();

        }



    }
}
