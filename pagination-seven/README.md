_This topic is taken from https://codingdojo.org/fr/kata/PaginationSeven/ _

Overview of the dojo
====================

The goal of this dojo is to implementation a pagination system similar to the one that exists on several web sites.



What we want to implement
=========================
In practice say we consider a total of 100 pages and that we are currently browsing the page 42, then we want to display: `1 … 41 (42) 43 … 100`.

More precisely we want to implement a system that:
- always displays the id of the first and last pages
- always displays the id of the previous and next pages (if they exist, of course)
- displays the id of the current page between brackets.
- displays up to 7 "token" (if there are at least 7 pages, of course)

where a token is either the id of a page or the character "…" to represent ids not displayed

Those examples should make it clearer
- page 2 over 5: "1 (2) 3 4 5"
- page 6 over 7: "1 2 3 4 5 (6) 7"
- page 42 over 100: "1 … 41 (42) 43 … 100"
- page 2 over 9: "1 (2) 3 4 5 … 9"
- page 4 over 9: "1 2 3 (4) 5 … 9"

What skills are trained with this topic
=======================================

- *TDD*: even though the tests are already written, passing them one by one is a great way to observe how this iterative approach leads to quickly deliver value, before all the features are available
- *Algorithm*: handling all corner cases may be tricky depending on the approach used
- *Clean code*: the hard part is to get an implementation that handles correctly all corner cases AND that can be easily understood by a reader

How this dojo is intended to be performed
=========================================
Open the test suite, uncomment the tests one by one, and complete the implementation to turn them green one after the other.
And make sure you end up with clean code (ie: that can be easily understood and edited by anyone): this, is IMHO the most interesting (and challenging 😅) part of that topic.
