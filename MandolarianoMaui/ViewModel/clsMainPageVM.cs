using BL;
using Entidades;
using MandolarianoMaui.ViewModel.Utilidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MandolarianoMaui.ViewModel
{
    public class clsMainPageVM : clsVMBase
    {

        #region Atributos

        private List<clsMisiones> listadoMisionesCompleto;
        private clsMisiones misionSeleccionada;
        private DelegateCommand mostrarDetallesCommand;
        private bool datosMisionEsVisible;

        #endregion


        #region Propiedades

        public List<clsMisiones> ListadoMisionesCompleto
        {
            get { return listadoMisionesCompleto; }
            
        }


        public clsMisiones MisionSeleccionada
        {
            get { return misionSeleccionada; }
            set { misionSeleccionada = value; }
        }

        public DelegateCommand MostrarDetallesCommand
        {
            get {
                mostrarDetallesCommand = new DelegateCommand(mostrarDetallesCommand_Execute, mostrarDetallesCommand_CanExecute);
                return mostrarDetallesCommand; }
           
        }

        public bool DatosMisionEsVisible 
        { 
            get => datosMisionEsVisible;
      
        }


        #endregion

        #region Constructores
        #endregion

        #region Comandos
        /// <summary>
        /// Método que devolverá un booleano que indicará si puede o no ejecutarse
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool mostrarDetallesCommand_CanExecute()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mostrará los detalles de la misión seleccionada mediante el booleano datosMisionEsVisible
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void mostrarDetallesCommand_Execute()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

