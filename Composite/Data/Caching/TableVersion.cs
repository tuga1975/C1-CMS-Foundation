﻿using System;
using System.Globalization;
using System.Threading;
using Composite.Core.Collections.Generic;
using Composite.Data.Types;
using Composite.C1Console.Events;
using Composite.Core.Types;

namespace Composite.Data.Caching
{
    internal static class TableVersion
    {
        private static readonly Hashtable<string, ExtendedNullable<int>> _versionNumbers = new Hashtable<string, ExtendedNullable<int>>();
        private static Hashset<Type> _subscribedTo = new Hashset<Type>();
        private static int _flushCounter;

        static TableVersion()
        {
            GlobalEventSystemFacade.SubscribeToFlushEvent(OnFlushEvent);
        }

        public static int Get(Type type)
        {
            Verify.ArgumentNotNull(type, "type");

            if(typeof(IMediaFile).IsAssignableFrom(type))
            {
                type = typeof (IMediaFileData);
            }

            EnsureSubscribtion(type);

            string key = GetKey(type);
            ExtendedNullable<int> record = _versionNumbers[key];

            return _flushCounter + (record == null ? 0 : record.Value);
        }

        private static string GetKey(Type type)
        {
            return GetKey(type, DataScopeManager.MapByType(type), LocalizationScopeManager.MapByType(type));
        }

        private static string GetKey(Type type, DataScopeIdentifier dataScopeIdentifier, CultureInfo cultureInfo)
        {
            return type.FullName + " " + dataScopeIdentifier.Name + " " + cultureInfo.Name;
        }

        private static void IncreaseTableVersion(Type type, DataScopeIdentifier dataScopeIdentifier, CultureInfo locale)
        {
            string key =  GetKey(type, dataScopeIdentifier, locale);

            lock (_versionNumbers)
            {
                if (_versionNumbers.ContainsKey(key))
                {
                    _versionNumbers[key].Value++;
                }
                else
                {
                    _versionNumbers.Add(key, 1);
                }
            }
        }

        private static void EnsureSubscribtion(Type type)
        {
            if (!_subscribedTo.Contains(type))
            {
                lock (_subscribedTo)
                {
                    if (!_subscribedTo.Contains(type))
                    {
                        _subscribedTo.Add(type);

                        DataEventSystemFacade.SubscribeToStoreChanged(type, (sender, storeEventArgs) => IncreaseTableVersion(type, DataScopeIdentifier.FromPublicationScope(storeEventArgs.PublicationScope), storeEventArgs.Locale), false);
                    }
                }
            }
        }

        private static void OnFlushEvent(FlushEventArgs args)
        {
            Interlocked.Increment(ref _flushCounter);
            _subscribedTo = new Hashset<Type>();
        }
    }
}
