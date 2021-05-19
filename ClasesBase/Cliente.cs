﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private int cli_Id;

        public int Cli_Id
        {
            get { return cli_Id; }
            set { cli_Id = value; }
        }
        private string cli_Nombre;

        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }
        private string cli_Domicilio;

        public string Cli_Domicilio
        {
            get { return cli_Domicilio; }
            set { cli_Domicilio = value; }
        }
        private string cli_Departamento;

        public string Cli_Departamento
        {
            get { return cli_Departamento; }
            set { cli_Departamento = value; }
        }
        private string cli_Codigo_Postal;

        public string Cli_Codigo_Postal
        {
            get { return cli_Codigo_Postal; }
            set { cli_Codigo_Postal = value; }
        }
        private string cli_Telefono;

        public string Cli_Telefono
        {
            get { return cli_Telefono; }
            set { cli_Telefono = value; }
        }
        private string cli_Email;

        public string Cli_Email
        {
            get { return cli_Email; }
            set { cli_Email = value; }
        }
        private DateTime cli_Fecha_Nac;

        public DateTime Cli_Fecha_Nac
        {
            get { return cli_Fecha_Nac; }
            set { cli_Fecha_Nac = value; }
        }

        //contructores
        public Cliente() { }
        public Cliente(
             int cli_Id,
             string cli_Nombre,
             string cli_Domicilio,
             string cli_Departamento,
             string cli_Codigo_Postal,
             string cli_Telefono,
             DateTime cli_Fecha_Nac)
        {
            this.cli_Id = cli_Id;
            this.cli_Nombre = cli_Nombre;
            this.cli_Domicilio = cli_Domicilio;
            this.cli_Departamento = cli_Departamento;
            this.cli_Codigo_Postal = cli_Codigo_Postal;
            this.cli_Telefono = cli_Telefono;
            this.cli_Fecha_Nac = cli_Fecha_Nac;

        }
    }
}
