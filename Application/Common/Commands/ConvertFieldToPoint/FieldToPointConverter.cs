using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Commands.ConvertFieldToPoint
{
    public class FieldToPointConverter: IFieldToPointConverter
    {
        public Point ConvertFrom(string fieldName)
        {
            if (fieldName == null)
                throw new ArgumentNullException(nameof(fieldName));

            var x = (int)fieldName.Substring(0, 1)[0] - (int)'A';
            var y = int.Parse(fieldName.Substring(1, fieldName.Length - 1)) - 1;
            return new Point(x, y);
        }
    }
}
