using System;
using AxelApp.BL;
using System.Collections.Generic;
using System.IO;

namespace AxelApp.Datos
{
    public class RepositorioDeTemperaturas
    {
        private readonly string _archivo = Environment.CurrentDirectory + @"\temperaturas.txt";
        //private readonly string _archivoBak = Environment.CurrentDirectory + @"\temperaturas.bak";
        public List<Temperatura> listaTemperaturas { get; set; }

        public RepositorioDeTemperaturas()
        {
            listaTemperaturas = new List<Temperatura>();
            LeerDelArchivo();
        }
        public void Agregar(Temperatura temperatura)
        {
            listaTemperaturas.Add(temperatura);
            GuardarEnArchivo(temperatura);
        }

        public void Borrar(Temperatura temperatura)
        {
            listaTemperaturas.Remove(temperatura);
        }

        public int GetCantidad()
        {
            return listaTemperaturas.Count;
        }

        public List<Temperatura> GetLista()
        {
            return listaTemperaturas;
        }

        public void GuardarEnArchivo(Temperatura temperatura)
        {
            StreamWriter escritor = new StreamWriter(_archivo, true);
            string linea = ConstruirLinea(temperatura);
            escritor.WriteLine(linea);
            escritor.Close();
        }

        private string ConstruirLinea(Temperatura temperatura)
        {
            return $"{temperatura.Valor}";
        }

        private void LeerDelArchivo()
        {
            StreamReader lector = new StreamReader(_archivo);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                var temp = ConstruirTemperatura(linea);
                listaTemperaturas.Add(temp);
            }
            lector.Close();
            
        }

        private Temperatura ConstruirTemperatura(string linea)
        {
            var campos = linea.Split('|');//"10|20"
            Temperatura temp = new Temperatura();
            temp.Valor = int.Parse(campos[0]);
            return temp;

        }
    }
}
