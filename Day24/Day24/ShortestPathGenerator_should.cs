﻿using System.Collections.Generic;
using NUnit.Framework;

namespace Day24
{
    class ShortestPathGenerator_should
    {
        [Test]
        public void intialize_with_paths()
        {
            var pathGenerator = new ShortestPathGenerator();

            pathGenerator.AddLinks(new List<Link> {Any.Link()});

            Assert.AreEqual(1, pathGenerator.LinkCount);
        }

        [Test]
        public void intialize_with_duplicate_paths()
        {
            var pathGenerator = new ShortestPathGenerator();
            var link = Any.Link();
            var linkCpy = link;
            var linkCpy2 = link;
            linkCpy.Length += 1;
            linkCpy2.Length -= 1;

            pathGenerator.AddLinks(new List<Link> { link, linkCpy, linkCpy2 });

            Assert.AreEqual(1, pathGenerator.LinkCount);
        }

        [Test]
        public void intialize_with_duplicate_paths_keep_lowest()
        {
            var pathGenerator = new ShortestPathGenerator();
            var link = Any.Link();
            var linkCpy = link;
            var linkCpy2 = link;
            linkCpy.Length += 1;
            linkCpy2.Length -= 1;

            pathGenerator.AddLinks(new List<Link> { link, linkCpy, linkCpy2 });
            pathGenerator.FindAllPaths();

            Assert.AreEqual(linkCpy2.Length, pathGenerator.ShortestPathLength);
        }

        //[Test]
        //public void find_path_when_only_two_locations()
        //{
        //    var pathGenerator = new ShortestPathGenerator();

        //    pathGenerator.AddLinks(new List<Link> { Any.Link() });
        //    var path = pathGenerator.FindAllPaths();

        //    Assert.AreEqual(1, pathGenerator.LinkCount);
        //}

        [Test]
        public void find_path_length_when_only_two_locations()
        {
            var pathGenerator = new ShortestPathGenerator();
            var link = Any.Link();
            pathGenerator.AddLinks(new List<Link> { link });
            pathGenerator.FindAllPaths();

            Assert.AreEqual(link.Length, pathGenerator.ShortestPathLength);
        }

        [Test]
        public void find_shortest_path_when_multiple_locations()
        {
            Assert.Fail();
        }

        [Test]
        public void find_shortest_path_length_count_with_multiple_locations()
        {
            Assert.Fail();
        }

        [Test]
        public void create_all_permutations_of_points()
        {
            var pathGenerator = new ShortestPathGenerator();
            var points = new HashSet<Point>();
            for (var i = 0; i < 2; i++)
            {
                for(var j = 0; j < 2; j++)
                {
                    points.Add(new Point(i, j));
                }
            }

            pathGenerator.EnumerateAllPaths(new Point(0, 0), points);

        }
    }
}
