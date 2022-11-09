using BL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MandolarianoMaui.ViewModel
{
    public class clsListaMisionesVM
    {

        // Se crea un ObservableCollection de tipo clsMisiones y se le añade un get
        public ObservableCollection<clsMisiones> listaMisionesCompleta { get; }


        // Constructor donde se inicializa el ObservableCollection creada anteriormente y se le mete la lista completa devuelva por la BL
        public clsListaMisionesVM()
        {

            listaMisionesCompleta = clsListaMisionesBL.listaMisionesCompletaBL();

        }

        


    }
}
