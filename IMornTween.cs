using System;
using Cysharp.Threading.Tasks;

namespace MornTween
{
    public interface IMornTween : IDisposable
    {
        UniTask GetAwaiter();
    }
}