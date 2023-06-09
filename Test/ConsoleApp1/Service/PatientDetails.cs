﻿using System;
using ConsoleApp1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Functionality;

namespace ConsoleApp1.Service
{
    class GeneralMedicine : Interface
    {
        Patient obj = new Patient();
        List<Patient> list = new List<Patient>();

        public int addPatient(Patient temp)
        {
            list.Add(temp);
            return 1;
        }

        public List<Patient> display()
        {
            if (list.Count > 0)
            {
                foreach (Patient pt in list)
                {
                    Console.WriteLine("Patient Registration Id : " + pt.PatientRegistrationId);
                    Console.WriteLine("Patient Name            : " + pt.PatientFirstName + " " + pt.PatientLastName);
                    Console.WriteLine("Patient Phone Number    : " + pt.PatientPhoneNo);
                    Console.WriteLine("Patient Gender          : " + pt.PatientGender);
                    Console.WriteLine("Patient Age             : " + pt.PatientAge);
                    Console.WriteLine("Patient Address         : " + pt.PatientAddress);
                    Console.WriteLine("Patient Adhar Number    : " + pt.PatientAdharNo);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("List is Empty...");
            }
            return list;
        }
    }
    class Orthopaedics : Interface
    {
        Patient obj = new Patient();
        List<Patient> list = new List<Patient>();

        public int addPatient(Patient temp)
        {
            list.Add(temp);
            return 1;
        }

        public List<Patient> display()
        {
            if (list.Count > 0)
            {
                foreach (Patient pt in list)
                {
                    Console.WriteLine("Patient Registration Id : " + pt.PatientRegistrationId);
                    Console.WriteLine("Patient Name            : " + pt.PatientFirstName + " " + pt.PatientLastName);
                    Console.WriteLine("Patient Phone Number    : " + pt.PatientPhoneNo);
                    Console.WriteLine("Patient Gender          : " + pt.PatientGender);
                    Console.WriteLine("Patient Age             : " + pt.PatientAge);
                    Console.WriteLine("Patient Address         : " + pt.PatientAddress);
                    Console.WriteLine("Patient Adhar Number    : " + pt.PatientAdharNo);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("List is Empty..");
            }
            return list;
        }

    }
    class Dental : Interface
    {
        Patient obj = new Patient();
        List<Patient> list = new List<Patient>();

        public int addPatient(Patient temp)
        {
            list.Add(temp);
            return 1;
        }

        public List<Patient> display()
        {
            if (list.Count > 0)
            {
                foreach (Patient pt in list)
                {
                    Console.WriteLine("Patient Registration Id : " + pt.PatientRegistrationId);
                    Console.WriteLine("Patient Name            : " + pt.PatientFirstName + " " + pt.PatientLastName);
                    Console.WriteLine("Patient Phone Number    : " + pt.PatientPhoneNo);
                    Console.WriteLine("Patient Gender          : " + pt.PatientGender);
                    Console.WriteLine("Patient Age             : " + pt.PatientAge);
                    Console.WriteLine("Patient Address         : " + pt.PatientAddress);
                    Console.WriteLine("Patient Adhar Number    : " + pt.PatientAdharNo);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("List is Empty..");
            }
            return list;
        }

    }

}