using System.Collections.Generic;

namespace DomainReplayer.FakeDomain
{
    public class ADomainObject
    {
        private readonly List<DomainEvent> _listOfChanges;

        public ADomainObject()
        {
            _listOfChanges = new List<DomainEvent>();
        }

        public void DoSomething()
        {
            _listOfChanges.Add(new DomainEvent());
        }

        public IEnumerable<DomainEvent> GetChanges()
        {
            return _listOfChanges;
        }
    }
}