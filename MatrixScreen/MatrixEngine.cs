using System.Drawing;
using FerretLib.SFML;
using SFML.Graphics;
using SFML.Window;
using Color = SFML.Graphics.Color;
using Font = SFML.Graphics.Font;

namespace MatrixScreen
{
    public class MatrixEngine : IWorldEngine
    {
        private ViewPortCollection _viewports;
        private Text text;

        public MatrixEngine()
        {
            text = new Text {
                Font = new Font(@"data\lekton.ttf"),                
                CharacterSize = 12,
                Color = Color.Green,
            };
        }

        #region IWorldEngine
        void IWorldEngine.Render()
        {
            foreach (var viewport in _viewports)
            {
                viewport.Window.Clear(Color.Black);

                text.Color = viewport.WorkingArea.Contains(Mouse.GetPosition().ToPoint()) ?
                    Color.Green : Color.Red;

                text.Position = new Vector2f(30, 30);
                text.DisplayedString = string.Format("Cursor: {0}:{1}", Mouse.GetPosition().X, Mouse.GetPosition().Y);
                viewport.Window.Draw(text);

                text.Position = new Vector2f(30, 44);
                text.DisplayedString = string.Format("Viewport #{0}; origin: {1},{2}",
                    viewport.ID,
                    viewport.WorkingArea.Top,
                    viewport.WorkingArea.Left);                
                viewport.Window.Draw(text);

                text.Position = new Vector2f(30, 58);
                text.DisplayedString = string.Format("Global boundaries: t:{0},l:{1},r:{2},b{3}",
                    _viewports.WorkingArea.Top,
                    _viewports.WorkingArea.Left,
                    _viewports.WorkingArea.Right,
                    _viewports.WorkingArea.Bottom);
                viewport.Window.Draw(text);

                viewport.Window.Display();
            }
        }

        void IWorldEngine.Update()
        {
            
        }

        void IWorldEngine.Initialise(ViewPortCollection viewports)
        {
            _viewports = viewports;
        }
        #endregion
        
    }
}
