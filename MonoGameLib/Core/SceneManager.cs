using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using MonoGameLib.Interfaces;

namespace MonoGameLib.Core
{
    public abstract class SceneManager : Interfaces.ISceneManager
    {
        public IScene CurrentScene => _currentScene;

        protected IScene _currentScene;

        protected Dictionary<string, IScene> _scenes { get; set; }

        public void Initialize()
        {
            _scenes = new Dictionary<string, IScene>();

            CreateScenes(_scenes);

            // Initialise all of the scenes
            for (int i = 0; i < _scenes.Count; i++)
            {
                _scenes.ToList()[0].Value.Initialize();
            }

            _currentScene = GetStartingScene();
        }

        /// <summary>
        /// Create the scenes needed for this scene manager
        /// </summary>
        /// <param name="scenes"></param>
        protected abstract void CreateScenes(Dictionary<string, IScene> scenes);

        protected abstract IScene GetStartingScene();

        public IScene GetScene(string sceneKey)
        {
            if (_scenes.Keys.Contains(sceneKey))
                return _scenes[sceneKey];
            else
                throw new Exceptions.SceneDoesNotExistException(sceneKey);
        }


        public virtual void LoadContent(ContentManager content)
        {
            // Loop through scenes and load the content
            for(int i =0; i < _scenes.Count; i++)
            {
                _scenes.ToList()[0].Value.LoadContent(content);
            }
        }

        public virtual void SwitchScene(string sceneKey)
        {
            _currentScene = GetScene(sceneKey);
        }
    }
}
