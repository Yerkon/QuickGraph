using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Observers;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Observers
{
    /// <summary>
    /// This class contains parameterized unit tests for VertexPredecessorRecorderObserver`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(VertexPredecessorRecorderObserver<, >))]
    public partial class VertexPredecessorRecorderObserverTVertexTEdgeTest
    {
        [PexMethod]
        public void Attach<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexPredecessorRecorderObserver<TVertex, TEdge> target,
            ITreeBuilderAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Attach(algorithm);
            // TODO: add assertions to method VertexPredecessorRecorderObserverTVertexTEdgeTest.Attach(VertexPredecessorRecorderObserver`2<!!0,!!1>, ITreeBuilderAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public VertexPredecessorRecorderObserver<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            VertexPredecessorRecorderObserver<TVertex, TEdge> target
               = new VertexPredecessorRecorderObserver<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method VertexPredecessorRecorderObserverTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public VertexPredecessorRecorderObserver<TVertex, TEdge> Constructor01<TVertex,TEdge>(IDictionary<TVertex, TEdge> vertexPredecessors)
            where TEdge : IEdge<TVertex>
        {
            VertexPredecessorRecorderObserver<TVertex, TEdge> target
               = new VertexPredecessorRecorderObserver<TVertex, TEdge>(vertexPredecessors);
            return target;
            // TODO: add assertions to method VertexPredecessorRecorderObserverTVertexTEdgeTest.Constructor01(IDictionary`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Detach<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexPredecessorRecorderObserver<TVertex, TEdge> target,
            ITreeBuilderAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Detach(algorithm);
            // TODO: add assertions to method VertexPredecessorRecorderObserverTVertexTEdgeTest.Detach(VertexPredecessorRecorderObserver`2<!!0,!!1>, ITreeBuilderAlgorithm`2<!!0,!!1>)
        }

        [PexMethod]
        public void VertexPredecessorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexPredecessorRecorderObserver<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, TEdge> result = target.VertexPredecessors;
            PexStore.ValueForValidation<IDictionary<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method VertexPredecessorRecorderObserverTVertexTEdgeTest.VertexPredecessorsGet(VertexPredecessorRecorderObserver`2<!!0,!!1>)
        }
        
    }
}
