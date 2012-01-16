﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using NGitHub.Utility;
using NGitHub.Web;

namespace NGitHub {
    public class GitHubRequest {
        private readonly string _resource;
        private readonly API _version;
        private readonly Method _method;
        private readonly object _body;
        private readonly ReadOnlyCollection<Parameter> _parameters;

        public GitHubRequest(string resource,
                             API version,
                             Method method,
                             params Parameter[] parameters)
            : this(resource, version, method, /*body:*/null, parameters) {
        }

        public GitHubRequest(string resource,
                             API version,
                             Method method,
                             object body,
                             params Parameter[] parameters) {
            Requires.ArgumentNotNull(resource, "resource");

            _resource = resource;
            _version = version;
            _method = method;
            _body = body;
            _parameters = (parameters == null) ? new ReadOnlyCollection<Parameter>(new List<Parameter>()) :
                                                 new ReadOnlyCollection<Parameter>(parameters);
        }

        public string Resource {
            get {
                return _resource;
            }
        }

        public API Version {
            get {
                return _version;
            }
        }

        public Method Method {
            get {
                return _method;
            }
        }

        public object Body {
            get {
                return _body;
            }
        }

        public ReadOnlyCollection<Parameter> Parameters {
            get {
                return _parameters;
            }
        }
    }
}