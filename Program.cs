using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SampleFrameworkApp.Practical
{
    enum Cause { external_factors, internal_disorder }
    class Disease
    {
        public string DiseaseName { get; set; }
        public string DiseaseSeverity { get; set; }
        public string Description { get; set; }
    }
     class DeatailsOfDisease:Disease
    {
        public string DiseaseDetails  { get; set; }

       

        internal static void UpdateDisease(DeatailsOfDisease dise)
        {
            throw new NotImplementedException();
        }
    }

    class Research
    {
        Disease[] diseases = null;
        DeatailsOfDisease[] symptoms = null;
        internal string DiseaseName;
        internal string DiseaseSeverity;
        private readonly int _size;

        public Research(int size)
        {
            _size = size;
            diseases = new Disease[_size];
            symptoms = new DeatailsOfDisease[_size];
            
        }
        public void AddNewDisease(Disease dise)
        {
            for(int i=0;i<diseases.Length;i++)
            {
                if(diseases[i]==null)
                {
                    diseases[i] = new Disease { DiseaseName = dise.DiseaseName, DiseaseSeverity = dise.DiseaseSeverity };
                    Console.WriteLine("Disease added successfully");
                    return;
                }
            }
        }

        public void AddDetails(DeatailsOfDisease dls)
        {
            for(int i=0;i<diseases.Length;i++)
            {
                if (diseases[i].DiseaseName == dls.DiseaseName && diseases[i].DiseaseSeverity == dls.DiseaseSeverity)
                {
                    symptoms[i] = new DeatailsOfDisease { DiseaseName = dls.DiseaseName, DiseaseSeverity = dls.DiseaseSeverity };
                    return;
                }
                throw new Exception("Disease is not found");
            }
        }

        public void UpdateDisease(DeatailsOfDisease dls)
        {
            for(int i=0;i<diseases.Length;i++)
            {
                if (diseases[i].DiseaseName == dls.DiseaseName && diseases[i].DiseaseSeverity == dls.DiseaseSeverity) ;
                {
                    diseases[i].DiseaseName = dls.DiseaseName;
                    diseases[i].DiseaseSeverity = dls.DiseaseSeverity;
                    return;
                }
            }
            throw new Exception("Diseases is not found to update");
        }
    }


    class MedicalResearch
    {
        static void Main(string[] args)
        {
            Disease dls = new DeatailsOfDisease { DiseaseName = "Mononucleosis", DiseaseSeverity = "high" };
            Research reseach = new Research(10);
            DeatailsOfDisease dise = new DeatailsOfDisease { DiseaseName = "Malaria", DiseaseSeverity = "high" };
            DeatailsOfDisease.AddDetails(dise);
            DeatailsOfDisease.UpdateDisease(dise);
        }
    }
}
