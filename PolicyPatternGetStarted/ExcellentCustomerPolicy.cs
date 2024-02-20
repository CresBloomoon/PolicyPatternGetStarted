using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyPatternGetStarted {
    internal sealed class ExcellentCustomerPolicy {
        private readonly HashSet<ExcellentCustomerRule> _rules;

        public ExcellentCustomerPolicy() {
            _rules = new HashSet<ExcellentCustomerRule>();
        }

        /// <summary>
        /// ルールを追加
        /// </summary>
        /// <param name="rule"></param>
        public void Add(ExcellentCustomerRule rule) {
            _rules.Add(rule);
        }

        public bool ComplyWithAll(PurchaseHistory history) {
            foreach(var each in _rules) {
                if (!each.OK(history)) return false;
            }
            return true;
        }
    }
}
