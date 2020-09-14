﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ch02_1.Shapes;

namespace ch02_2.BeanFactory
{
    enum ShapeType
    {
        Rectangle,
        Squre,
        Triangle,
    }

    class Factory
    {
        public Shape GetRandomShape()
        {
            ShapeType[] shapeTypes = Enum.GetValues(typeof(ShapeType)) as ShapeType[];
            Random random = new Random();
            ShapeType shapeType = shapeTypes[random.Next(0, shapeTypes.Length)];
            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.Squre:
                    return new Square();
                case ShapeType.Triangle:
                    return new Triangle();
                default:
                    return null;
            }
        }
    }
}