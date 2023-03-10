using BenchmarkDotNet.Attributes;
using Binacle.Lib.Components.Models;

namespace Binacle.Lib.Benchmarks.Strategies
{
    [RankColumn]
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.SlowestToFastest)]
    public class DecreasingVolumeSizeFirstFittingOrientationBenchmarks
    {
        private readonly StrategyFactory strategyFactory;
        private readonly List<Item> items_10_5x5x5;
        private readonly List<Item> items_20_5x5x5;
        private readonly List<Item> items_40_5x5x5;
        private readonly List<Item> items_60_5x5x5;
        private readonly List<Item> items_80_5x5x5;
        private readonly List<Item> items_100_5x5x5;
        private readonly List<Bin> bins;

        public DecreasingVolumeSizeFirstFittingOrientationBenchmarks()
        {
            this.strategyFactory = new Binacle.Lib.StrategyFactory();

            var _5x5x5 = new Dimensions(5, 5, 5);

            this.items_10_5x5x5 = Enumerable.Range(1, 10).Select(x => new Item(x.ToString(), _5x5x5)).ToList();
            this.items_20_5x5x5 = Enumerable.Range(1, 20).Select(x => new Item(x.ToString(), _5x5x5)).ToList();
            this.items_40_5x5x5 = Enumerable.Range(1, 40).Select(x => new Item(x.ToString(), _5x5x5)).ToList();
            this.items_60_5x5x5 = Enumerable.Range(1, 60).Select(x => new Item(x.ToString(), _5x5x5)).ToList();
            this.items_80_5x5x5 = Enumerable.Range(1, 80).Select(x => new Item(x.ToString(), _5x5x5)).ToList();
            this.items_100_5x5x5 = Enumerable.Range(1, 100).Select(x => new Item(x.ToString(), _5x5x5)).ToList();

            this.bins = new List<Bin>()
            {
                new Bin("Small", new Dimensions(8,45,62)),
                new Bin("Medium", new Dimensions(17,45,62)),
                new Bin("Large", new Dimensions(36,45,62))
            };
        }

        [Benchmark]
        public void With_10_5x5x5()
        {
            var strategy = this.strategyFactory.Create(Components.Strategies.BinFittingStrategy.DecreasingVolumeSizeFirstFittingOrientation)
                .WithBins(this.bins)
                .AndItems(this.items_10_5x5x5)
                .Build();

            var result = strategy.Execute();
        }

        [Benchmark]
        public void With_20_5x5x5()
        {
            var strategy = this.strategyFactory.Create(Components.Strategies.BinFittingStrategy.DecreasingVolumeSizeFirstFittingOrientation)
                .WithBins(this.bins)
                .AndItems(this.items_20_5x5x5)
                .Build();

            var result = strategy.Execute();
        }

        [Benchmark]
        public void With_40_5x5x5()
        {
            var strategy = this.strategyFactory.Create(Components.Strategies.BinFittingStrategy.DecreasingVolumeSizeFirstFittingOrientation)
                .WithBins(this.bins)
                .AndItems(this.items_40_5x5x5)
                .Build();

            var result = strategy.Execute();
        }

        [Benchmark]
        public void With_60_5x5x5()
        {
            var strategy = this.strategyFactory.Create(Components.Strategies.BinFittingStrategy.DecreasingVolumeSizeFirstFittingOrientation)
                .WithBins(this.bins)
                .AndItems(this.items_60_5x5x5)
                .Build();

            var result = strategy.Execute();
        }

        [Benchmark]
        public void With_80_5x5x5()
        {
            var strategy = this.strategyFactory.Create(Components.Strategies.BinFittingStrategy.DecreasingVolumeSizeFirstFittingOrientation)
                .WithBins(this.bins)
                .AndItems(this.items_80_5x5x5)
                .Build();

            var result = strategy.Execute();
        }

        [Benchmark]
        public void With_100_5x5x5()
        {
            var strategy = this.strategyFactory.Create(Components.Strategies.BinFittingStrategy.DecreasingVolumeSizeFirstFittingOrientation)
                .WithBins(this.bins)
                .AndItems(this.items_100_5x5x5)
                .Build();

            var result = strategy.Execute();
        }
    }
}
