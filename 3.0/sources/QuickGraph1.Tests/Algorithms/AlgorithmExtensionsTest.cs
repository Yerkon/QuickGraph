using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Condensation;
using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for AlgorithmExtensions
    /// </summary>
    [TestClass]
    [PexClass(typeof(AlgorithmExtensions))]
    public partial class AlgorithmExtensionsTest
    {
        [PexMethod]
        public void Clone<TVertex,TEdge>(
            IVertexAndEdgeListGraph<TVertex, TEdge> g,
            IMutableVertexAndEdgeListGraph<TVertex, TEdge> clone
        )
            where TVertex : ICloneable
            where TEdge : ICloneableEdge<TVertex>
        {
            AlgorithmExtensions.Clone<TVertex, TEdge>(g, clone);
            // TODO: add assertions to method AlgorithmExtensionsTest.Clone(IVertexAndEdgeListGraph`2<!!0,!!1>, IMutableVertexAndEdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public double ComputePredecessorCost<TVertex,TEdge>(
            IDictionary<TVertex, TEdge> predecessors,
            IDictionary<TEdge, double> edgeCosts,
            TVertex target
        )
            where TEdge : IEdge<TVertex>
        {
            double result = AlgorithmExtensions.ComputePredecessorCost<TVertex, TEdge>
                (predecessors, edgeCosts, target);
            return result;
            // TODO: add assertions to method AlgorithmExtensionsTest.ComputePredecessorCost(IDictionary`2<!!0,!!1>, IDictionary`2<!!1,Double>, !!0)
        }
        
        [PexMethod]
        public void Condensate<TVertex,TEdge,TGraph>(IVertexAndEdgeListGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
            where TGraph : IMutableVertexAndEdgeListGraph<TVertex, TEdge>, new()
        {
            IMutableBidirectionalGraph<TGraph, CondensatedEdge<TVertex, TEdge, TGraph>> 
              result = AlgorithmExtensions.Condensate<TVertex, TEdge, TGraph>(g);
            PexStore.ValueForValidation<IMutableBidirectionalGraph
                <TGraph, CondensatedEdge<TVertex, TEdge, TGraph>>>("result", result);
            // TODO: add assertions to method AlgorithmExtensionsTest.Condensate(IVertexAndEdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public int ConnectedComponents<TVertex,TEdge>(
            IUndirectedGraph<TVertex, TEdge> g,
            TVertex startVertex,
            IDictionary<TVertex, int> components
        )
            where TEdge : IEdge<TVertex>
        {
            int result = AlgorithmExtensions.ConnectedComponents<TVertex, TEdge>
                (g, startVertex, components);
            return result;
            // TODO: add assertions to method AlgorithmExtensionsTest.ConnectedComponents(IUndirectedGraph`2<!!0,!!1>, !!0, IDictionary`2<!!0,Int32>)
        }
        
        [PexMethod]
        public bool IsDirectedAcyclicGraph<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            bool result = AlgorithmExtensions.IsDirectedAcyclicGraph<TVertex, TEdge>(g);
            return result;
            // TODO: add assertions to method AlgorithmExtensionsTest.IsDirectedAcyclicGraph(IVertexListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void IsolatedVertices<TVertex,TEdge>(IBidirectionalGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result
               = AlgorithmExtensions.IsolatedVertices<TVertex, TEdge>(visitedGraph);
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            PexEnumerablePatterns.ForEach<TVertex>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TVertex>(result);
            PexEnumerablePatterns.MoveNextAndReset<TVertex>(result);
            // TODO: add assertions to method AlgorithmExtensionsTest.IsolatedVertices(IBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void OddVertices<TVertex,TEdge>(IVertexAndEdgeListGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            List<TVertex> result = AlgorithmExtensions.OddVertices<TVertex, TEdge>(g);
            PexStore.ValueForValidation<List<TVertex>>("result", result);
            PexEnumerablePatterns.ForEach<TVertex>((IEnumerable<TVertex>)result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TVertex>((IEnumerable<TVertex>)result);
            PexEnumerablePatterns.MoveNextAndReset<TVertex>((IEnumerable<TVertex>)result);
            // TODO: add assertions to method AlgorithmExtensionsTest.OddVertices(IVertexAndEdgeListGraph`2<!!0,!!1>)
        }

        [PexMethod]
        public void Roots<TVertex,TEdge>(IBidirectionalGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result
               = AlgorithmExtensions.Roots<TVertex, TEdge>(visitedGraph);
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            PexEnumerablePatterns.ForEach<TVertex>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TVertex>(result);
            PexEnumerablePatterns.MoveNextAndReset<TVertex>(result);
            // TODO: add assertions to method AlgorithmExtensionsTest.Roots(IBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Roots01<TVertex,TEdge>(IUndirectedGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result
               = AlgorithmExtensions.Roots<TVertex, TEdge>(visitedGraph);
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            PexEnumerablePatterns.ForEach<TVertex>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TVertex>(result);
            PexEnumerablePatterns.MoveNextAndReset<TVertex>(result);
            // TODO: add assertions to method AlgorithmExtensionsTest.Roots01(IUndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Roots02<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result
               = AlgorithmExtensions.Roots<TVertex, TEdge>(visitedGraph);
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            PexEnumerablePatterns.ForEach<TVertex>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TVertex>(result);
            PexEnumerablePatterns.MoveNextAndReset<TVertex>(result);
            // TODO: add assertions to method AlgorithmExtensionsTest.Roots02(IVertexListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Sinks<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result
               = AlgorithmExtensions.Sinks<TVertex, TEdge>(visitedGraph);
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            PexEnumerablePatterns.ForEach<TVertex>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TVertex>(result);
            PexEnumerablePatterns.MoveNextAndReset<TVertex>(result);
            // TODO: add assertions to method AlgorithmExtensionsTest.Sinks(IVertexListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void SourceFirstTopologicalSort<TVertex,TEdge>(IVertexAndEdgeListGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result = 
              AlgorithmExtensions.SourceFirstTopologicalSort<TVertex, TEdge>(visitedGraph);
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            PexEnumerablePatterns.ForEach<TVertex>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TVertex>(result);
            PexEnumerablePatterns.MoveNextAndReset<TVertex>(result);
            // TODO: add assertions to method AlgorithmExtensionsTest.SourceFirstTopologicalSort(IVertexAndEdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void SourceFirstTopologicalSort01<TVertex,TEdge>(IVertexAndEdgeListGraph<TVertex, TEdge> visitedGraph, IList<TVertex> vertices)
            where TEdge : IEdge<TVertex>
        {
            AlgorithmExtensions.SourceFirstTopologicalSort<TVertex, TEdge>
                (visitedGraph, vertices);
            // TODO: add assertions to method AlgorithmExtensionsTest.SourceFirstTopologicalSort01(IVertexAndEdgeListGraph`2<!!0,!!1>, IList`1<!!0>)
        }
        
        [PexMethod]
        public int StronglyConnectedComponents<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> g, IDictionary<TVertex, int> components)
            where TEdge : IEdge<TVertex>
        {
            int result = AlgorithmExtensions.StronglyConnectedComponents<TVertex, TEdge>
                (g, components);
            return result;
            // TODO: add assertions to method AlgorithmExtensionsTest.StronglyConnectedComponents(IVertexListGraph`2<!!0,!!1>, IDictionary`2<!!0,Int32>)
        }
        
        [PexMethod]
        public void TopologicalSort<TVertex,TEdge>(IUndirectedGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result
               = AlgorithmExtensions.TopologicalSort<TVertex, TEdge>(visitedGraph);
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            PexEnumerablePatterns.ForEach<TVertex>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TVertex>(result);
            PexEnumerablePatterns.MoveNextAndReset<TVertex>(result);
            // TODO: add assertions to method AlgorithmExtensionsTest.TopologicalSort(IUndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void TopologicalSort01<TVertex,TEdge>(IUndirectedGraph<TVertex, TEdge> visitedGraph, IList<TVertex> vertices)
            where TEdge : IEdge<TVertex>
        {
            AlgorithmExtensions.TopologicalSort<TVertex, TEdge>(visitedGraph, vertices);
            // TODO: add assertions to method AlgorithmExtensionsTest.TopologicalSort01(IUndirectedGraph`2<!!0,!!1>, IList`1<!!0>)
        }
        
        [PexMethod]
        public void TopologicalSort02<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result
               = AlgorithmExtensions.TopologicalSort<TVertex, TEdge>(visitedGraph);
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            PexEnumerablePatterns.ForEach<TVertex>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TVertex>(result);
            PexEnumerablePatterns.MoveNextAndReset<TVertex>(result);
            // TODO: add assertions to method AlgorithmExtensionsTest.TopologicalSort02(IVertexListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void TopologicalSort03<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> visitedGraph, IList<TVertex> vertices)
            where TEdge : IEdge<TVertex>
        {
            AlgorithmExtensions.TopologicalSort<TVertex, TEdge>(visitedGraph, vertices);
            // TODO: add assertions to method AlgorithmExtensionsTest.TopologicalSort03(IVertexListGraph`2<!!0,!!1>, IList`1<!!0>)
        }
        
        [PexMethod]
        public int WeaklyConnectedComponents<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> g, IDictionary<TVertex, int> components)
            where TEdge : IEdge<TVertex>
        {
            int result = 
              AlgorithmExtensions.WeaklyConnectedComponents<TVertex, TEdge>(g, components);
            return result;
            // TODO: add assertions to method AlgorithmExtensionsTest.WeaklyConnectedComponents(IVertexListGraph`2<!!0,!!1>, IDictionary`2<!!0,Int32>)
        }
        
    }
}
