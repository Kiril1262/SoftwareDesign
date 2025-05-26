<?php
interface Visitor {
    public function visit(Element $element);
}

class CountVisitor implements Visitor {
    public $count = 0;

    public function visit(Element $element) {
        $this->count++;
        foreach ($element->children as $child) {
            $this->visit($child);
        }
    }
}
