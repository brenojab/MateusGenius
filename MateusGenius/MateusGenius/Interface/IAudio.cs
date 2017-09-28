using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateusGenius.Interface
{
  public interface IAudio
  {
    bool PlayMp3File(int Id, string fileName);
  }
}
