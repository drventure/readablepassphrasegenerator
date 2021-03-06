﻿// Copyright 2011 Murray Grant
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using MurrayGrant.ReadablePassphrase.WordTemplate;
using MurrayGrant.ReadablePassphrase.Words;

namespace MurrayGrant.ReadablePassphrase.MaterialisedWords
{
    public sealed class MaterialisedVerb : Verb
    {
        private readonly string _PresentSingular;
        private readonly string _PastSingular;
        private readonly string _PastContinuousSingular;
        private readonly string _FutureSingular;
        private readonly string _ContinuousSingular;
        private readonly string _PerfectSingular;
        private readonly string _SubjunctiveSingular;

        private readonly string _PresentPlural;
        private readonly string _PastPlural;
        private readonly string _PastContinuousPlural;
        private readonly string _FuturePlural;
        private readonly string _ContinuousPlural;
        private readonly string _PerfectPlural;
        private readonly string _SubjunctivePlural;

        private readonly bool _IsTransitive;

        public override string PresentSingular { get { return _PresentSingular; } }
        public override string PastSingular { get { return _PastSingular; } }
        public override string PastContinuousSingular { get { return _PastContinuousSingular; } }
        public override string FutureSingular { get { return _FutureSingular; } }
        public override string ContinuousSingular { get { return _ContinuousSingular; } }
        public override string PerfectSingular { get { return _PerfectSingular; } }
        public override string SubjunctiveSingular { get { return _SubjunctiveSingular; } }

        public override string PresentPlural { get { return _PresentPlural; } }
        public override string PastPlural { get { return _PastPlural; } }
        public override string PastContinuousPlural { get { return _PastContinuousPlural; } }
        public override string FuturePlural { get { return _FuturePlural; } }
        public override string ContinuousPlural { get { return _ContinuousPlural; } }
        public override string PerfectPlural { get { return _PerfectPlural; } }
        public override string SubjunctivePlural { get { return _SubjunctivePlural; } }

        public override bool IsTransitive { get { return _IsTransitive; } }

        public MaterialisedVerb(IDictionary<string, string> forms)
        {
            _PresentSingular = GetOrDefault(forms, "presentSingular");
            _PastSingular = GetOrDefault(forms, "pastSingular");
            _PastContinuousSingular = GetOrDefault(forms, "pastContinuousSingular");
            _FutureSingular = GetOrDefault(forms, "futureSingular");
            _ContinuousSingular = GetOrDefault(forms, "continuousSingular");
            _PerfectSingular = GetOrDefault(forms, "perfectSingular");
            _SubjunctiveSingular = GetOrDefault(forms, "subjunctiveSingular");

            _PresentPlural = GetOrDefault(forms, "presentPlural");
            _PastPlural = GetOrDefault(forms, "pastPlural");
            _PastContinuousPlural = GetOrDefault(forms, "pastContinuousPlural");
            _FuturePlural = GetOrDefault(forms, "futurePlural");
            _ContinuousPlural = GetOrDefault(forms, "continuousPlural");
            _PerfectPlural = GetOrDefault(forms, "perfectPlural");
            _SubjunctivePlural = GetOrDefault(forms, "subjunctivePlural");
        }
        public MaterialisedVerb(string presentSingular, string pastSingular, string pastContinuousSingular, string futureSingular, string continuousSingular, string perfectSingular, string subjunctiveSingular,
                                string presentPlural, string pastPlural, string pastContinuousPlural, string futurePlural, string continuousPlural, string perfectPlural, string subjunctivePlural,
                                bool isTransitive)
        {
            _PresentSingular = presentSingular;
            _PastSingular = pastSingular;
            _PastContinuousSingular = pastContinuousSingular;
            _FutureSingular = futureSingular;
            _ContinuousSingular = continuousSingular;
            _PerfectSingular = perfectSingular;
            _SubjunctiveSingular = subjunctiveSingular;

            _PresentPlural = presentPlural;
            _PastPlural = pastPlural;
            _PastContinuousPlural = pastContinuousPlural;
            _FuturePlural = futurePlural;
            _ContinuousPlural = continuousPlural;
            _PerfectPlural = perfectPlural;
            _SubjunctivePlural = subjunctivePlural;

            _IsTransitive = isTransitive;
        }

        private string GetOrDefault(IDictionary<string, string> dict, string key)
            => dict.TryGetValue(key, out var result) ? result : "";
    }
}
