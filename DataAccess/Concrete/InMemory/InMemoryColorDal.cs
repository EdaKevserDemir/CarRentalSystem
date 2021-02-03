﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;

        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                new Color{ColorId=1,ColorName="Blue"},
                new Color{ColorId=2,ColorName="Red"},
                new Color{ColorId=3,ColorName="Black"},
                new Color{ColorId=4,ColorName="Grey"}

            };
        }

        public void Add(Color color)
        {
            _colors.Add(color);
        }
        public void Update(Color color)
        {
            Color colorToUpdate = _colors.SingleOrDefault(c=>c.ColorId==color.ColorId);
            colorToUpdate.ColorId = color.ColorId;
            colorToUpdate.ColorName = color.ColorName;
        }
        public void Delete(Color color)
        {
            Color colorToDelete = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            _colors.Remove(colorToDelete);
        }

        public List<Color> GetAll()
        {
            return _colors;
        }

        public List<Color> GetById(int colorId)
        {
            return _colors.Where(c => c.ColorId == colorId).ToList();
        }

      
    }
}
