/*************************************************************************
 *  Copyright © 2018 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ContextMenuItem.cs
 *  Description  :  Define context menu item.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  9/16/2018
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;
using UnityEngine.Events;

namespace Mogoson.ContextMenu
{
    /// <summary>
    /// Item of context menu.
    /// </summary>
    public abstract class ContextMenuItem : MonoBehaviour, IContextMenuItem
    {
        #region Field and Property
        /// <summary>
        /// Name of menu item.
        /// </summary>
        [SerializeField]
        protected string itemName = "Item Name";

        /// <summary>
        /// Name of menu item.
        /// </summary>
        public string ItemName
        {
            set { itemName = value; }
            get { return itemName; }
        }

        /// <summary>
        /// Interactable of menu item.
        /// </summary>
        public abstract bool Interactable { set; get; }
        #endregion

        #region Public Method
        /// <summary>
        /// Add listener to menu item.
        /// </summary>
        /// <param name="callback">Callback function.</param>
        public abstract void AddListener(UnityAction callback);

        /// <summary>
        /// Remove listener from menu item.
        /// </summary>
        /// <param name="callback">Callback function.</param>
        public abstract void RemoveListener(UnityAction callback);
        #endregion
    }
}