#!/usr/bin/env python

####+BEGIN: b:prog:file/particulars :authors ("./inserts/authors-mb.org")
""" #+begin_org
* *[[elisp:(org-cycle)][| Particulars |]]* :: Authors, version
** This File: /bisos/git/bxRepos/bisos-pip/graphviz-cs/py3/bin/exmpl-graphviz.cs
** Authors: Mohsen BANAN, http://mohsen.banan.1.byname.net/contact
#+end_org """
####+END:

""" #+begin_org
* Panel::  [[file:/bisos/panels/bisos-apps/lcnt/lcntScreencasting/subTitles/_nodeBase_/fullUsagePanel-en.org]]
* Overview and Relevant Pointers
#+end_org """

from bisos import b
from bisos.b import cs

from bisos.capability import cba_sysd_seed
from bisos.capability import cba_seed


cba_seed.setup(
    seedType="systemd",  # Extend using cba_sysd_seed.setup
    loader=None,
    binsPrep="siteRegistrars-binsPrep.cs",
    assemble="siteRegistrars-assemble.cs",
    materialize=None,
    # examplesHook=qmail_binsPrep.examples_csu,
)


sysdUnitsList = [
    cba_sysd_seed.sysdUnit("siteRegistrars")
]

cba_sysd_seed.setup(
    sysdUnitsList=sysdUnitsList,
)


####+BEGIN: b:py3:cs:seed/withWhich :seedName "/bisos/git/bxRepos/bisos-pip/capability/py3/bin/cba-sysd.cs"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  seed       [[elisp:(outline-show-subtree+toggle)][||]] <</bisos/git/bxRepos/bisos-pip/capability/py3/bin/cba-sysd.cs>>   [[elisp:(org-cycle)][| ]]
#+end_org """
import shutil
import os
import sys

seedName = '/bisos/git/bxRepos/bisos-pip/capability/py3/bin/cba-sysd.cs'
seedPath = shutil.which(seedName)
if seedPath is None:
    print(f'sys.exit() --- which found nothing for {seedName} --- Aborting')
    sys.exit()

__file__ = os.path.abspath(seedPath)
with open(__file__) as f:
    exec(compile(f.read(), __file__, 'exec'))

####+END: