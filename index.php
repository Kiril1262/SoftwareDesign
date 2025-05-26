<?php
require_once "core/Element.php";
require_once "core/Command.php";
require_once "core/State.php";
require_once "core/Visitor.php";
require_once "core/Iterator.php";
?>

<!DOCTYPE html>
<html lang="uk">
<head>
    <meta charset="UTF-8">
    <title>Солодкий блог</title>
    <link rel="stylesheet" href="task/style/style.css?v=<?php echo time(); ?>">
</head>
<body>
<?php
// Створення елементів
$blog = new Element("div");
$title = new Element("h1", "🍰 Вітаємо у солодкому блозі!");

// Рецепт 1 — Наполеон
$recipe1 = new Element("div");
$recipe1->addChild(new Element("h2", "Торт 'Наполеон'"));
$recipe1->addChild(new Element("p", "Класичний багатошаровий торт із хрусткими коржами та ніжним заварним кремом. Ідеально смакує після охолодження в холодильнику, коли кожен шар просочується вершковим ароматом."));

// Рецепт 2 — Макаруни
$recipe2 = new Element("div");
$recipe2->addChild(new Element("h2", "Макаруни"));
$recipe2->addChild(new Element("p", "Французькі витончені тістечка з мигдалевого борошна, що тануть у роті. Хрустка скоринка та ніжна начинка з ганашу або фруктового пюре створюють ідеальний баланс."));

// Рецепт 3 — Чізкейк
$recipe3 = new Element("div");
$recipe3->addChild(new Element("h2", "Чізкейк"));
$recipe3->addChild(new Element("p", "Неймовірно ніжний десерт із вершковим сиром та крихкою основою з печива. Найкраще смакує з ягідним топінгом або карамельним соусом. Ідеальний до чашечки кави."));

// Рецепт 4 — Тірамісу
$recipe4 = new Element("div");
$recipe4->addChild(new Element("h2", "Тірамісу"));
$recipe4->addChild(new Element("p", "Легендарний італійський десерт із ніжного маскарпоне, просоченого кавою бісквіту та легкою ноткою какао. Не вимагає випікання й завжди викликає захоплення гостей."));

// Додавання до блогу
$blog->addChild($title);
$blog->addChild($recipe1);
$blog->addChild($recipe2);
$blog->addChild($recipe3);
$blog->addChild($recipe4);

// Команда на стиль
$cmd = new AddStyleCommand($title, "color: #ff79c6");
$cmd->execute();

// Стейт
$context = new BlogContext();
$context->setState(new PublishedState());
echo "<p>{$context->getState()}</p>";

// Відвідувач — підрахунок елементів
$visitor = new CountVisitor();
$visitor->visit($blog);
echo "<p>Усього рецептів: {$visitor->count}</p>";

// Рендеринг
$blog->render();

// Ітератор — перелік тегів
echo "<p>Список тегів:</p><ul>";
$iterator = new ElementIterator($blog);
foreach ($iterator as $element) {
    echo "<li>{$element->tag}</li>";
}
echo "</ul>";
?>
</body>
</html>


