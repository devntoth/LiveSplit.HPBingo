using System;
using LiveSplit.HPBingo.Components;
using LiveSplit.Model;
using LiveSplit.UI.Components;

[assembly: ComponentFactory(typeof(LiveSplit.HPBingo.Factories.HPBingoFactory))]

namespace LiveSplit.HPBingo.Factories
{
    public class HPBingoFactory : IComponentFactory
    {
        public string ComponentName => BingoConstants.COMPONENT_NAME;

        public string Description => BingoConstants.COMPONENT_DESCRIPTION;

        public ComponentCategory Category => ComponentCategory.Control;

        public string UpdateName => BingoConstants.COMPONENT_NAME;

        public string XMLURL => string.Empty;

        public string UpdateURL => string.Empty; // @todo: add github releases page later...

        public Version Version => Version.Parse("0.0.1");

        public IComponent Create(LiveSplitState state)
        {
            return new HPBingoComponent(state);
        }
    }
}
