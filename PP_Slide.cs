﻿using System.Collections.Generic;
namespace PP_ShapeInfo
{
    public class PP_Slide
    {
        public PP_Slide(ICollection<PP_Shape> slideShapes)
        {
            SlideShapes = slideShapes;
        }

        public ICollection<PP_Shape> SlideShapes { get; }
    }
}
