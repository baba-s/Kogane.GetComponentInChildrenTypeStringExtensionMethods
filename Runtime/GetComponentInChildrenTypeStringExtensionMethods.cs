using System.Linq;
using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// GetComponentInChildren や GetComponentsInChildren で引数の型情報を文字列で渡せるようにする拡張メソッド
    /// </summary>
    public static class GetComponentInChildrenTypeStringExtensionMethods
    {
        public static Component GetComponentInChildren( this GameObject self, string type )
        {
            return self.GetComponentInChildren( type, false );
        }

        public static Component GetComponentInChildren( this GameObject self, string type, bool includeInactive )
        {
            foreach ( var transform in self.GetComponentsInChildren<Transform>( includeInactive ) )
            {
                var component = transform.gameObject.GetComponent( type );

                if ( component != null ) return component;
            }

            return null;
        }

        public static Component[] GetComponentsInChildren( this GameObject self, string type )
        {
            return self.GetComponentsInChildren( type, false );
        }

        public static Component[] GetComponentsInChildren( this GameObject self, string type, bool includeInactive )
        {
            return self
                .GetComponentsInChildren<Transform>( includeInactive )
                .Select( x => x.gameObject.GetComponent( type ) )
                .Where( x => x != null )
                .ToArray();
            ;
        }

        public static Component GetComponentInChildren( this Component self, string type )
        {
            return self.gameObject.GetComponentInChildren( type );
        }

        public static Component GetComponentInChildren( this Component self, string type, bool includeInactive )
        {
            return self.gameObject.GetComponentInChildren( type, includeInactive );
        }

        public static Component[] GetComponentsInChildren( this Component self, string type )
        {
            return self.gameObject.GetComponentsInChildren( type );
        }

        public static Component[] GetComponentsInChildren( this Component self, string type, bool includeInactive )
        {
            return self.gameObject.GetComponentsInChildren( type, includeInactive );
        }
    }
}