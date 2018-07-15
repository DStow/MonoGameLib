using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLib.Interfaces
{
    public interface ISceneManager : IInitializable
    {
        /// <summary>
        /// Current scene being offered up
        /// </summary>
        IScene CurrentScene { get; }

        /// <summary>
        /// Change the current scene
        /// </summary>
        /// <param name="sceneKey">The scene key to change to</param>
        void SwitchScene(string sceneKey);
    }
}
