using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    internal class ForeignerManager : IApplicantService
    {
        void IApplicantService.ApplyFormMask(Person person)
        {
            throw new NotImplementedException();
        }

        bool IApplicantService.CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        List<Person> IApplicantService.GetList()
        {
            throw new NotImplementedException();
        }
    }
}
