using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Utilities {
    public class MyCacheProvider : CachingProviderBase, IGlobalCachingProvider {
        public MyCacheProvider() { }
        public static MyCacheProvider Instance {
            get {
                return Nested.instance;
            }
        }
        class Nested {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested() {
            }
            internal static readonly MyCacheProvider instance = new MyCacheProvider();
        }
        public virtual new void AddItem(string key, object value) {
            base.AddItem(key, value);
        }

        public virtual new void SetItemValue(string key, object value) {
            base.SetItemValue(key, value);
        }

        public virtual object GetItem(string key) {
            return base.GetItem(key, true);//Remove default is true because it's Global Cache!
        }

        public virtual new object GetItem(string key, bool remove) {
            return base.GetItem(key, remove);
        }
    }
    public interface IGlobalCachingProvider {

        void AddItem(string key, object value);
        void SetItemValue(string key, object value);
        object GetItem(string key);
    }
    public abstract class CachingProviderBase {
        protected MemoryCache cache = new MemoryCache("CachingProvider");

        static readonly object padlock = new object();
        CacheItemPolicy cacheItemPolicy = new CacheItemPolicy {
            AbsoluteExpiration = MemoryCache.InfiniteAbsoluteExpiration,
            SlidingExpiration = TimeSpan.FromMinutes(10)
        };
        protected virtual void AddItem(string key, object value) {
            lock (padlock) {
                cache.Add(key, value, cacheItemPolicy);
            }
        }
        protected virtual void SetItemValue(string key, object value) {
            lock (padlock) {
                cache.Set(key, value, cacheItemPolicy);
            }
        }

        protected virtual void RemoveItem(string key) {
            lock (padlock) {
                cache.Remove(key);
            }
        }

        protected virtual object GetItem(string key, bool remove) {
            lock (padlock) {
                var value = cache.Get(key);
                //var res = cache.GetCacheItem(key);

                if (value != null) {
                    if (remove == true)
                        cache.Remove(key);
                }
                else {
                    //WriteToLog("CachingProvider-GetItem: Don't contains key: " + key);
                }

                return value;
            }
        }
    }
}