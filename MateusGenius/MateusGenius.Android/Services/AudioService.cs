using Xamarin.Forms;
using Android.Media;
using MateusGenius.Interface;
using MateusGenius.Droid.Services;
using System.Threading.Tasks;

[assembly: Dependency(typeof(AudioService))]
namespace MateusGenius.Droid.Services
{
  public class AudioService : IAudio
  {
    public System.Collections.Generic.Stack<int> pilha { get; set; }

    public AudioService()
    {
      if (pilha == null)
        pilha = new System.Collections.Generic.Stack<int>();
    }

    private MediaPlayer _mediaPlayer;

    public bool PlayMp3File(int id, string fileName)
    {

      pilha.Clear();
      if (pilha.Count > 0)
      {

        foreach (var item in pilha)
        {
          Task.Delay(1000);
          PlaySound("test" + item);
          Task.Delay(1000);
        }
        pilha.Push(id);

      }
      else
      {
        PlaySound(fileName);
        pilha.Push(id);
      }
      return true;
    }

    private void PlaySound(string fileName)
    {
      switch (fileName)
      {
        case "test1":
          _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.test1);
          break;
        case "test2":
          _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.test2);
          break;
        case "test3":
          _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.test3);
          break;
        case "test4":
          _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.test4);
          break;

        default:
          _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.test1);
          break;
      }

      Task.Delay(1000);
      _mediaPlayer.Start();
      _mediaPlayer = null;
      Task.Delay(1000);
    }
  }
}
