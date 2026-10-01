namespace SoundMeter.Models;

public interface ISceneGraphItem
{
    string Name { get; }

    void Render(IRenderContext renderContext);
}

public interface ISceneGraphLeaf : ISceneGraphItem
{

}

public interface ISceneGraphNode : ISceneGraphItem, System.Collections.Generic.ICollection<ISceneGraphItem>
{

}

public interface ISceneGraph : ISceneGraphItem
{
    ISceneGraphNode Root { get; }
}