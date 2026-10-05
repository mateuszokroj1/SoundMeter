
namespace SoundMeter.Framework.CAD.Visualization.SceneComposition;

public interface ISceneComponent
{
    string Name { get; }

    void Render(IRenderContext renderContext);
}