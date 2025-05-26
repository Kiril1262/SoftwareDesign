<?php
interface BlogState {
    public function displayState();
}

class DraftState implements BlogState {
    public function displayState() {
        return "Статус: Чернетка";
    }
}

class PublishedState implements BlogState {
    public function displayState() {
        return "Статус: Опубліковано!";
    }
}

class BlogContext {
    private $state;

    public function setState(BlogState $state) {
        $this->state = $state;
    }

    public function getState() {
        return $this->state->displayState();
    }
}
