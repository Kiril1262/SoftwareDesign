<?php
class ElementIterator implements Iterator {
    private $stack = [];
    private $position = 0;

    public function __construct($root) {
        $this->stack[] = $root;
    }

    public function current(): mixed {
        return end($this->stack);
    }

    public function next(): void {
        $element = array_pop($this->stack);
        if ($element->children) {
            foreach (array_reverse($element->children) as $child) {
                $this->stack[] = $child;
            }
        }
    }

    public function key(): mixed {
        return $this->position++;
    }

    public function valid(): bool {
        return !empty($this->stack);
    }

    public function rewind(): void {
        $this->position = 0;
    }
}


