using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mktm.ts3tools.s3sr
{
    public class Stencils
    {
        public class OBJD
        {
            public ulong IMG_ReplaceInstance;
            public ulong IMG_Instance;
            public uint StencilID;

            public OBJD(string instruction)
            {
                string[] stencil = instruction.Split(';');
                this.IMG_ReplaceInstance = Convert.ToUInt64(stencil[0], 16);
                this.IMG_Instance = Convert.ToUInt64(stencil[1], 16);
                this.StencilID = Convert.ToUInt32(stencil[2], 16);
            }

            /// <summary>
            /// Build OBJDStencil List from String Pattern
            /// </summary>
            /// <param name="instruction">String Pattern</param>
            /// <returns>The List of OBJD Stencils parsed</returns>
            public static List<Stencils.OBJD> Create(string[] instruction)
            {
                List<Stencils.OBJD> ret = new List<Stencils.OBJD>();
                foreach (string stencil in instruction)
                    ret.Add(new Stencils.OBJD(stencil.Split(':')[1]));
                return ret;
            }
        }
    }
}