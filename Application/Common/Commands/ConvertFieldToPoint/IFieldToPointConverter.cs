using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Commands.ConvertFieldToPoint
{
    public interface IFieldToPointConverter
    {
        Point ConvertFrom(string fieldName);
    }
}
