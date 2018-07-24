using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLib.Exceptions
{
    /// <summary>
    /// This exception is thrown when a scene cannot be found by a scene manager
    /// </summary>
    public class SceneDoesNotExistException : ApplicationException
    {
        public string SceneKey { get; set; }

        public SceneDoesNotExistException(string sceneKey)
            : base(String.Format("The scene '{0}' does not exist", sceneKey))
        {
            this.SceneKey = sceneKey;
        }
    }
}
