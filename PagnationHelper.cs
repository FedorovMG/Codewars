using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codewars
{
    public class PagnationHelper<T>
    {
        //https://www.codewars.com/kata/515bb423de843ea99400000a
        // TODO: Complete this class
        readonly int ItemPerPage;

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            Collection = collection;
            ItemPerPage = itemsPerPage;
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                Console.WriteLine($"Count - {Collection.Count}");
                return Collection.Count;
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
                int count = (int)Math.Round((double)(ItemCount / ItemPerPage), MidpointRounding.ToNegativeInfinity);
                Console.WriteLine($"Page {count} - {ItemCount} / {ItemPerPage}");
                return count;
            }
        }

        public IList<T> Collection { get; }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            Console.WriteLine($"index - {pageIndex}, page count - {PageCount}");
            if (pageIndex >= PageCount || pageIndex < 0)
            {
                return -1;
            }
            int minItem = pageIndex * ItemPerPage;
            int maxItem = pageIndex * ItemPerPage + ItemPerPage;
            Console.WriteLine($"min - {minItem}, max - {maxItem}");
            if (maxItem > ItemCount)
            {
                maxItem = ItemCount;
            }
            return maxItem - minItem;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            Console.WriteLine($"index - {itemIndex}, count - {ItemCount}");
            if (itemIndex >= ItemCount || itemIndex < 0)
            {
                return -1;
            }
            return itemIndex/ItemPerPage;
        }
    }
}