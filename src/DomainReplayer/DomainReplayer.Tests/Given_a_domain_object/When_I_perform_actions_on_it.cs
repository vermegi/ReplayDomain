using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DomainReplayer.Tests.Given_a_domain_object
{
    public class When_I_perform_actions_on_it
    {
        [Fact]
        public void It_can_give_me_a_list_of_changes()
        {
            var sut = new ADomainObject();
            sut.DoSomething();
            var changes = sut.GetChanges();
            Assert.Equal(1, changes.Count());
        }
    }

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

    public class DomainEvent
    {
    }
}